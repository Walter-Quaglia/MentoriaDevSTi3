using MentoriaDevSTi3.Business;
using MentoriaDevSTi3.ViewModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MentoriaDevSTi3.View.UserControls
{
    /// <summary>
    /// Interaction logic for UcClientes.xaml
    /// </summary>
    public partial class UcClientes : UserControl
    {
        private UcClienteViewModel UcClienteVm = new UcClienteViewModel();

        public UcClientes()
        {
            InitializeComponent();

            DataContext = UcClienteVm;
           
            UcClienteVm.DataNascimento = new System.DateTime(1990, 1, 1);

            CarregarRegistros();
        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarCliente())
                return;

            if (UcClienteVm.Alteracao)
            {
                AlterarCliente();
            }
            else
            {
                AdicionarCliente();
            }

            LimparCampos();
        }

        private void BtnAlterar_Click(object sender, RoutedEventArgs e)
        {
            var cliente = (sender as Button).Tag as ClienteViewModel;

            PreencherCampos(cliente);
        }

        private void BtnRemover_Click(object sender, RoutedEventArgs e)
        {
            var cliente = (sender as Button).Tag as ClienteViewModel;

            RemoverCliente(cliente.Id);
        }

        private void PreencherCampos(ClienteViewModel cliente)
        {
            UcClienteVm.Id = cliente.Id;
            UcClienteVm.Nome = cliente.Nome;
            UcClienteVm.DataNascimento = cliente.DataNascimento;
            UcClienteVm.Cep = cliente.Cep;
            UcClienteVm.Endereco = cliente.Endereco;
            UcClienteVm.Cidade = cliente.Cidade;

            UcClienteVm.Alteracao = true;
        }

        private void CarregarRegistros()
        {
            UcClienteVm.ClientesAdicionados = new ObservableCollection<ClienteViewModel>(new ClienteBusiness().Listar());
        }

        private void AdicionarCliente()
        {
            var novoCliente = new ClienteViewModel
            {
                Nome = UcClienteVm.Nome,
                DataNascimento = UcClienteVm.DataNascimento,
                Cep = UcClienteVm.Cep,
                Endereco = UcClienteVm.Endereco,
                Cidade = UcClienteVm.Cidade
            };

            new ClienteBusiness().Adicionar(novoCliente);
            CarregarRegistros();
        }

        private void AlterarCliente()
        {
            var ClienteAlteracao = new ClienteViewModel
            {
                Id = UcClienteVm.Id,
                Nome = UcClienteVm.Nome,
                DataNascimento = UcClienteVm.DataNascimento,
                Endereco = UcClienteVm.Endereco,
                Cidade = UcClienteVm.Cidade,
                Cep = UcClienteVm.Cep
            };

            new ClienteBusiness().Alterar(ClienteAlteracao);
            CarregarRegistros();
        }

        private void RemoverCliente(long id)
        {
            var resultado = MessageBox.Show("Tem certeza de deseja remover o Cliente?", "Atenção", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (resultado == MessageBoxResult.Yes)
            {
                new ClienteBusiness().Remover(id);
                CarregarRegistros();
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            UcClienteVm.Nome = "";
            UcClienteVm.DataNascimento = new System.DateTime(1990, 1, 1);
            UcClienteVm.Cep = "";
            UcClienteVm.Endereco = "";
            UcClienteVm.Cidade = "";
            UcClienteVm.Alteracao = false;
        }

        private bool ValidarCliente()
        {
            if (string.IsNullOrEmpty(UcClienteVm.Nome))
            {
                MessageBox.Show("O campo nome é obrigatório.", "Atenção!", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }

            return true;
        }

        
    }
}
