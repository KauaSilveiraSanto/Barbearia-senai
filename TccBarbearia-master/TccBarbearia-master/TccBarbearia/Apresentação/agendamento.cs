using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TccBarbearia.Dal;
using TccBarbearia.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TccBarbearia.Apresentação
{
    public partial class agendamento : Form
    {
        public agendamento()
        {
            InitializeComponent();
            ConfigureComboBoxes();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // Recuperar informações do formulário
            DateTime dataSelecionada = DateTime.Parse(dtp_data.Value.Date.ToString("yyyy-MM-dd") + " " + cb_horario.SelectedItem?.ToString());
            string servicoSelecionado = cb_agendar.SelectedItem?.ToString();
            string nomeCliente = txb_nome.Text;
            string profissionalSelecionado = cb_profissionais.SelectedItem?.ToString();

            // Verificar se o nome foi inserido
            if (string.IsNullOrWhiteSpace(nomeCliente))
            {
                MessageBox.Show("Digite o nome do cliente antes de agendar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar disponibilidade considerando o profissional selecionado
            if (DataHoraOcupada(dataSelecionada, profissionalSelecionado))
            {
                MessageBox.Show("Este horário já está ocupado para o barbeiro selecionado. Escolha outro horário ou barbeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (servicoSelecionado == null)
            {
                MessageBox.Show("Selecione um serviço antes de agendar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (profissionalSelecionado == null)
            {
                MessageBox.Show("Selecione um profissional antes de agendar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Salvar no banco de dados
            using (SqlConnection connection = new SqlConnection(@"Data Source=G15EDUARDO\SQLEXPRESS;Initial Catalog=TccBarbearia;User ID=root;Password=123456"))
            {
                connection.Open();

                // Certifique-se de que a tabela 'agendar' existe no banco de dados
                string query = "INSERT INTO agendar (NomeCliente, DataSelecionada, ServicoSelecionado, ProfissionalSelecionado) " +
                               "VALUES (@NomeCliente, @DataSelecionada, @ServicoSelecionado, @ProfissionalSelecionado)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NomeCliente", nomeCliente);
                    command.Parameters.AddWithValue("@DataSelecionada", dataSelecionada);
                    command.Parameters.AddWithValue("@ServicoSelecionado", servicoSelecionado);
                    command.Parameters.AddWithValue("@ProfissionalSelecionado", profissionalSelecionado);

                    command.ExecuteNonQuery();
                }
            }

            // Mostra uma mensagem de sucesso
            MessageBox.Show("Agendado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ConfigureComboBoxes()
        {
            // Preencher o ComboBox de serviços
            cb_agendar.Items.AddRange(new object[] { "Barba - R$ 35,00","Corte de cabelo - R$ 40,00",
            "depilação nasal - R$ 15,00", "raspado - R$ 30,00", "sobrancelha - R$ 15,00" /* Adicione mais serviços conforme necessário */ });
            // Adicione um evento ao ValueChanged do DateTimePicker
            dtp_data.ValueChanged += (sender, e) => AtualizarHorarios();

            // Preencher o ComboBox de horários
            TimeSpan horarioAtual = new TimeSpan(8, 0, 0); // Horário inicial
            TimeSpan horarioFinal = new TimeSpan(18, 0, 0); // Horário final
            TimeSpan intervalo = new TimeSpan(0, 30, 0);     // Intervalo de 30 minutos

            while (horarioAtual < horarioFinal)
            {
                cb_horario.Items.Add(horarioAtual.ToString("hh\\:mm"));
                horarioAtual = horarioAtual.Add(intervalo);
            }
            // Definir a data mínima para o DateTimePicker como a data atual
            dtp_data.MinDate = DateTime.Today;

            // Adicionar um manipulador de eventos para o evento ValueChanged
            dtp_data.ValueChanged += dtp_data_ValueChanged;


            // Adicionar profissionais ao ComboBox
            cb_profissionais.Items.AddRange(new object[] { "Barbeiro Eduardo", "Barbeiro kauã" /* Adicione mais profissionais conforme necessário! */ });

            // Selecionar a primeira opção automaticamente, se houver opções
            if (cb_profissionais.Items.Count > 0)
            {
                cb_profissionais.SelectedIndex = 0;
            }

        }

        private void AtualizarHorarios()
        {
            // Recuperar a data selecionada do DateTimePicker
            DateTime dataSelecionada = dtp_data.Value.Date;

            // Verificar se é um dia útil (segunda a sexta-feira)
            if (dataSelecionada.DayOfWeek != DayOfWeek.Saturday && dataSelecionada.DayOfWeek != DayOfWeek.Sunday)
            {
                // Limpar os itens antigos
                cb_horario.Items.Clear();

                // Adicionar os horários disponíveis para a data selecionada
                TimeSpan horarioAtual = new TimeSpan(8, 0, 0); // Horário inicial
                TimeSpan horarioFinal = new TimeSpan(18, 0, 0); // Horário final
                TimeSpan intervalo = new TimeSpan(0, 30, 0);     // Intervalo de 30 minutos

                while (horarioAtual < horarioFinal)
                {
                    cb_horario.Items.Add(horarioAtual.ToString("hh\\:mm"));
                    horarioAtual = horarioAtual.Add(intervalo);
                }

                // Selecionar o primeiro horário automaticamente, se houver opções
                if (cb_horario.Items.Count > 0)
                {
                    cb_horario.SelectedIndex = 0;
                }
            }
            else
            {
                // Se for fim de semana, exibir mensagem ou tomar a ação desejada
                MessageBox.Show("Não são permitidos agendamentos aos fins de semana.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private bool DataHoraOcupada(DateTime dataHora, string profissionalSelecionado)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=G15EDUARDO\SQLEXPRESS;Initial Catalog=TccBarbearia;User ID=root;Password=123456"))
            {
                connection.Open();

                // Modifique a query para incluir a verificação do profissional
                string query = "SELECT COUNT(*) FROM agendar WHERE DataSelecionada = @DataSelecionada AND ProfissionalSelecionado = @ProfissionalSelecionado";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DataSelecionada", dataHora);
                    command.Parameters.AddWithValue("@ProfissionalSelecionado", profissionalSelecionado);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }




        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair? Se você sair, perderá qualquer progresso não salvo.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)

                this.Close();
            formAnterior.Show(); // Ou use formAnterior.Visible = true; se necessário
        }

        
    private Form formAnterior;

        public agendamento(Form formAnterior)
        {
            InitializeComponent();
            this.formAnterior = formAnterior;
            ConfigureComboBoxes();
        }

        private void dtp_data_ValueChanged(object sender, EventArgs e)
        {
            // Verificar se é um dia útil (segunda a sexta-feira)
            if (dtp_data.Value.DayOfWeek == DayOfWeek.Saturday || dtp_data.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                // Adicionar um dia até que seja um dia útil
                while (dtp_data.Value.DayOfWeek == DayOfWeek.Saturday || dtp_data.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    dtp_data.Value = dtp_data.Value.AddDays(1);
                }

                // Exibir uma mensagem indicando que fins de semana não são permitidos
                MessageBox.Show("Não são permitidos agendamentos aos fins de semana.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Verificar se a data selecionada é anterior à data mínima permitida
            if (dtp_data.Value < DateTime.Today)
            {
                // Definir a data selecionada como a data atual
                dtp_data.Value = DateTime.Today;

                // Exibir uma mensagem indicando que datas anteriores não são permitidas
                MessageBox.Show("Não é permitido selecionar datas anteriores à data atual.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}