using Microsoft.VisualBasic.ApplicationServices;
using Projeto_Windows_Form_02_Cadastro_de_clientes.Entities;
using Projeto_Windows_Form_02_Cadastro_de_clientes.Entities.Enums;
using Projeto_Windows_Form_02_Cadastro_de_clientes.Services;
using System.Net.Http.Headers;

namespace Projeto_Windows_Form_02_Cadastro_de_clientes.Screens
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
            if (selectClient.SelectedIndex < 0) editClientBtn.Enabled = false;
            EnabledBottomInputs(false);
            PopulateComboboxWithStates();
            PopulateComboboxWithClients();
        }

        // MÉTODOS DE AÇÕES DA SCREEN -------------------------------------------------------------------------

        private void RegisterScreenCloseWarning(object sender, FormClosingEventArgs e)
        {
            if (HasAnyUnsavedValue())
            {
                if (!ConfirmBoxShow("Deseja realmente fechar o formulário? Existem dados não salvos.")) e.Cancel = true;  // Cancela o fechamento do formulário se o usuário clicar em "Não"
            }
            else
            {
                if (!ConfirmBoxShow("Deseja realmente fechar o formulário?")) e.Cancel = true;  // Cancela o fechamento do formulário se o usuário clicar em "Não"
            }
        }

        private void EditClientBtn_Click(object sender, EventArgs e)
        {
            if (selectClient.SelectedIndex < 0) MessageBoxShow("Selecione um usuário para editar!");
            else
            {
                EnabledBottomInputs(true);
                EnabledTopInputs(false);
            }
        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            EnabledBottomInputs(true);
            EnabledTopInputs(false);
            CleanFields();
            clientName.Select();
            selectClient.SelectedIndex = -1;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (HasAnyEmptyField()) MessageBoxShow("Preencha os campos necessários!");      // Se algum campo de texto estiver vazio um alerta será exibido
            else                                                                            // se todos os campos estiverem preenchidos, o usuario será salvo
            {
                bool isNewUser = selectClient.SelectedIndex < 0;                                     // Se o usuário selecionado for menor que 0, significa que é um novo usuário

                if (!isNewUser)
                {
                    if (!HasAnyUnsavedValue())
                    {
                        MessageBoxShow("Não há dados para salvar, nenhuma alteração foi realizada.");
                        return;
                    }
                }

                if (VerifyIfHasUserWithSameData()) return;    // verificar se o novo usuário contém um CPF ou nome já cadastrado no sistema

                Usuario usuario = isNewUser ? new Usuario() : (Usuario)selectClient.SelectedItem;    // Se o usuário estiver editando um cliente, o cliente será atualizado, caso contrário, um novo cliente será criado
                FillFieldsOfNewUser(usuario);

                if (isNewUser)
                {
                    UserServices.InsertUser(usuario);
                    MessageBoxShow("Usuário inserido com sucesso!");
                }
                else MessageBoxShow("Usuário atualizado com sucesso!");

                PopulateComboboxWithClients(usuario);
                PopulateFieldsOfExistentUser(usuario);
                EnabledBottomInputs(false);
                EnabledTopInputs(true);
                if (selectClient.SelectedIndex < 0) editClientBtn.Enabled = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            bool isNewUser = selectClient.SelectedIndex < 0;
            // aviso de confirmação de cancelamento
            if (HasAnyUnsavedValue())
            {
                if (ConfirmBoxShow("Deseja realmente cancelar a operação?"))  // Exibe uma caixa de diálogo de confirmação
                {
                    if (!isNewUser) PopulateFieldsOfExistentUser((Usuario)selectClient.SelectedItem);
                    else CleanFields();
                }
                else return;
            }
            else if (isNewUser) CleanFields();

            EnabledBottomInputs(false);
            EnabledTopInputs(true);
            if (isNewUser) editClientBtn.Enabled = false;
        }

        private void CloseBtnClick(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário
        }

        private void SelectClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectClient.SelectedIndex < 0) editClientBtn.Enabled = false;
            else
            {
                // collect the user from the combobox
                Usuario client = (Usuario)selectClient.SelectedItem;
                PopulateFieldsOfExistentUser(client);
                editClientBtn.Enabled = true;
            }
        }


        // MÉTODOS AUXILIARES -------------------------------------------------------------------------------

        private static void MessageBoxShow(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static bool ConfirmBoxShow(string message)
        {
            if (MessageBox.Show(message, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)  // Exibe uma caixa de diálogo de confirmação
            {
                return true;
            }
            else return false;
        }

        private void EnabledTopInputs(bool enabled)
        {
            selectClient.Enabled = enabled;
            editClientBtn.Enabled = enabled;
            addClientBtn.Enabled = enabled;
        }

        private void EnabledBottomInputs(bool enabled)
        {
            clientName.Enabled = enabled;
            clientCPF.Enabled = enabled;
            clientChildren.Enabled = enabled;
            clientVehicle.Enabled = enabled;
            clientBirthdate.Enabled = enabled;
            clientIncome.Enabled = enabled;
            clientNacionality.Enabled = enabled;
            maritalStatusSingleRadio.Enabled = enabled;
            maritalStatusMarriedRadio.Enabled = enabled;
            maritalStatusDivorceRadio.Enabled = enabled;
            saveBtn.Enabled = enabled;
            cancelBtn.Enabled = enabled;
        }

        private void FillFieldsOfNewUser(Usuario User)
        {
            User.Nome = clientName.Text;
            User.Cpf = clientCPF.Text;
            User.Filhos = clientChildren.Checked;
            User.PlacaVeiculo = clientVehicle.Text;
            User.DataNascimento = clientBirthdate.Value.Date;
            User.Renda = (decimal)clientIncome.Value;
            User.Nacionalidade = (Estado)clientNacionality.SelectedItem;
            if (maritalStatusSingleRadio.Checked) User.EstadoCivil = EstadoCivil.Solteiro;
            if (maritalStatusMarriedRadio.Checked) User.EstadoCivil = EstadoCivil.Casado;
            if (maritalStatusDivorceRadio.Checked) User.EstadoCivil = EstadoCivil.Divorciado;
        }

        private void CleanFields()
        {
            clientCode.Clear();
            clientName.Clear();
            clientCPF.Clear();
            clientVehicle.Clear();
            clientBirthdate.Value = DateTime.Now.Date;
            clientIncome.Value = 0;
            clientNacionality.SelectedIndex = -1;
            clientChildren.Checked = false;
            maritalStatusSingleRadio.Checked = false;
            maritalStatusMarriedRadio.Checked = false;
            maritalStatusDivorceRadio.Checked = false;
        }

        private void PopulateFieldsOfExistentUser(Usuario user)
        {
            clientCode.Text = user.Codigo.ToString();
            clientName.Text = user.Nome;
            clientCPF.Text = user.Cpf;
            clientChildren.Checked = user.Filhos;
            clientVehicle.Text = user.PlacaVeiculo;
            clientBirthdate.Value = user.DataNascimento;
            clientIncome.Value = user.Renda;
            clientNacionality.SelectedValue = user.Nacionalidade.Sigla;
            if (user.EstadoCivil == EstadoCivil.Solteiro) maritalStatusSingleRadio.Checked = true;
            if (user.EstadoCivil == EstadoCivil.Casado) maritalStatusMarriedRadio.Checked = true;
            if (user.EstadoCivil == EstadoCivil.Divorciado) maritalStatusDivorceRadio.Checked = true;
        }
        private void PopulateComboboxWithStates()
        {
            // Adicionando os estados na lista
            clientNacionality.DataSource = Estados.Listagem;
            selectClient.DisplayMember = "";
            clientNacionality.DisplayMember = "Nome";
            clientNacionality.ValueMember = "Sigla";
            clientNacionality.SelectedIndex = -1;
        }

        private void PopulateComboboxWithClients(Usuario? user = null)
        {
            // Adicionando os clientes na lista
            selectClient.DataSource = UserServices.usuarios;
            selectClient.DisplayMember = "";
            selectClient.DisplayMember = "Nome";
            selectClient.ValueMember = "Codigo";
            if (user != null) selectClient.SelectedItem = user;
        }

        private bool HasAnyUnsavedValue()
        {
            if (selectClient.SelectedIndex < 0)
            {
                if (clientName.Text != "") return true;
                if (clientCPF.Text != "   .   .   -") return true;
                if (clientIncome.Value > 0) return true;
                if (clientVehicle.Text != "   -") return true;
                if (clientBirthdate.Value.Date != DateTime.Now.Date) return true;
                if (clientNacionality.SelectedItem != null) return true;
                if (maritalStatusDivorceRadio.Checked || maritalStatusMarriedRadio.Checked || maritalStatusSingleRadio.Checked) return true;
            }
            else
            {
                Usuario ClientSelected = (Usuario)selectClient.SelectedItem;
                if (clientName.Text != ClientSelected.Nome) return true;
                if (clientCPF.Text != ClientSelected.Cpf) return true;
                if (clientIncome.Value != ClientSelected.Renda) return true;
                if (clientVehicle.Text != ClientSelected.PlacaVeiculo) return true;
                if (clientBirthdate.Value.Date != ClientSelected.DataNascimento.Date) return true;
                if (clientNacionality.SelectedValue != ClientSelected.Nacionalidade.Sigla) return true;
                if (clientChildren.Checked != ClientSelected.Filhos) return true;
                if (maritalStatusDivorceRadio.Checked && ClientSelected.EstadoCivil != EstadoCivil.Divorciado) return true;
                if (maritalStatusMarriedRadio.Checked && ClientSelected.EstadoCivil != EstadoCivil.Casado) return true;
                if (maritalStatusSingleRadio.Checked && ClientSelected.EstadoCivil != EstadoCivil.Solteiro) return true;
            }
            return false;
        }

        private bool HasAnyEmptyField()
        {
            if (clientName.Text == "") return true;
            if (clientCPF.Text == "   .   .   -") return true;
            if (clientIncome.Value <= 0) return true;
            if (clientVehicle.Text == "   -") return true;
            if (clientBirthdate.Value.Date == DateTime.Now.Date) return true;
            if (clientNacionality.SelectedItem == null) return true;
            if (maritalStatusDivorceRadio.Checked == false && maritalStatusMarriedRadio.Checked == false && maritalStatusSingleRadio.Checked == false) return true;
            return false;
        }

        private bool VerifyIfHasUserWithSameData()
        {
            bool alreadyHave = false;
            foreach (Usuario usuario in UserServices.usuarios)
            {
                if (usuario.Cpf == clientCPF.Text && usuario.Codigo != int.Parse(clientCode.Text == "" ? "0" : clientCode.Text))
                {
                    MessageBoxShow("Já existe um usuário cadastrado com esse CPF! Por favor, tente novamente.");
                    alreadyHave = true;
                    break;
                }

                if (usuario.Nome == clientName.Text && usuario.Codigo != int.Parse(clientCode.Text == "" ? "0" : clientCode.Text))
                {
                    MessageBoxShow("Já existe um usuário cadastrado com esse nome! Por favor, tente novamente.");
                    alreadyHave = true;
                    break;
                }

                if (usuario.PlacaVeiculo == clientVehicle.Text && usuario.Codigo != int.Parse(clientCode.Text == "" ? "0" : clientCode.Text))
                {
                    MessageBoxShow("Já existe um usuário cadastrado com essa placa de veículo! Por favor, tente novamente.");
                    alreadyHave = true;
                    break;
                }
            }
            return alreadyHave;
        }


    }
}