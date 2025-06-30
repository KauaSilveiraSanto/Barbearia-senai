using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccBarbearia.Apresentação
{
    public partial class TelaBarbeiro : Form
    {
        public TelaBarbeiro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Se necessário, adicione lógica aqui
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agendamento ag = new agendamento(this);
            ag.Show();
            this.Hide(); // Opcional: ocultar o formulário atual, se desejar
        }

        private void TelaBarbeiro_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Na carga inicial, você pode exibir todos os agendamentos disponíveis ou uma mensagem indicando que nenhum agendamento foi selecionado.
            AtualizarAgendamentos(DateTime.Today);
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            // Recuperar a data selecionada do DateTimePicker
            DateTime dataSelecionada = calendar_m.Value.Date;

            // Chamar o método para atualizar os agendamentos no DataGridView
            AtualizarAgendamentos(dataSelecionada);
        }

        // Método para atualizar os agendamentos no DataGridView
        private void AtualizarAgendamentos(DateTime dataSelecionada)
        {
            // Consultar o banco de dados para obter os agendamentos para a data selecionada
            DataTable dataTable = ObterAgendamentosPorData(dataSelecionada);

            // Verificar se há algum agendamento para a data selecionada
            if (dataTable.Rows.Count > 0)
            {
                // Exibir o DataGridView se houver agendamentos
                dg_mostra.Visible = true;

                // Atualizar o DataGridView com os dados recuperados
                dg_mostra.DataSource = dataTable;
            }
            else
            {
                // Ocultar o DataGridView se não houver agendamentos
                dg_mostra.Visible = false;

                // Exibir uma mensagem indicando que não há agendamentos para a data selecionada
                MessageBox.Show("Não há agendamentos para a data selecionada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        // Método para obter os agendamentos para uma data específica
        private DataTable ObterAgendamentosPorData(DateTime data)
        {
            DataTable dataTable = new DataTable();

            // Construir a string de conexão com o banco de dados
            string connectionString = @"Data Source=G15EDUARDO\SQLEXPRESS;Initial Catalog=TccBarbearia;User ID=root;Password=123456";

            // Consultar o banco de dados e preencher o DataTable
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ProfissionalSelecionado, NomeCliente, ServicoSelecionado, DataSelecionada FROM agendar WHERE CONVERT(DATE, DataSelecionada) = @DataSelecionada";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DataSelecionada", data);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            // Ordenar o DataTable pelo horário (DataSelecionada)
            var rows = dataTable.AsEnumerable()
                                .OrderBy(row => row.Field<DateTime>("DataSelecionada"));

            // Criar um novo DataTable ordenado
            DataTable sortedTable = dataTable.Clone();
            foreach (var row in rows)
            {
                sortedTable.ImportRow(row);
            }

            return sortedTable;
        }



        private void calendar_m_ValueChanged(object sender, EventArgs e)
        {
            // Adicione lógica adicional aqui, se necessário
        }

        private void dg_mostra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Adicione lógica adicional aqui, se necessário
        }
    }
}
