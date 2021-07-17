using MentoriaDevSTi3.Business;
using MentoriaDevSTi3.ViewModel;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace MentoriaDevSTi3.View.UserControls
{
    /// <summary>
    /// Interaction logic for UcProdutos.xaml
    /// </summary>
    public partial class UcProdutos : UserControl
    {
        private UcProdutoViewModel UcProdutoVm = new UcProdutoViewModel();

        public UcProdutos()
        {
            InitializeComponent();

            DataContext = UcProdutoVm;

            CarregarRegistros();
        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarProduto()) return;

            if (UcProdutoVm.Alteracao)
            {
                AlterarProduto();
            }
            else
            {
                AdicionarProduto();
            }

            LimparCampos();
        }

        private void BtnAlterar_Click(object sender, RoutedEventArgs e)
        {
            var produto = (sender as Button).Tag as ProdutoViewModel;

            PreencherCampos(produto);
        }

        private void BtnRemover_Click(object sender, RoutedEventArgs e)
        {
            var produto = (sender as Button).Tag as ProdutoViewModel;

            RemoverProduto(produto.Id);
        }

        private void TxtValor_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void PreencherCampos(ProdutoViewModel produto)
        {

            UcProdutoVm.Id = produto.Id;
            UcProdutoVm.Nome = produto.Nome;
            UcProdutoVm.Valor = produto.Valor;

            UcProdutoVm.Alteracao = true;
        }

        private void CarregarRegistros() 
        {
            UcProdutoVm.ProdutosAdicionados = new ObservableCollection<ProdutoViewModel>(new ProdutoBusiness().Listar());
        }

        private void AdicionarProduto()
        {
            var novoProduto = new ProdutoViewModel
            {
                Nome = UcProdutoVm.Nome,
                Valor = UcProdutoVm.Valor
            };

            new ProdutoBusiness().Adicionar(novoProduto);
            CarregarRegistros();
        }

        private void AlterarProduto()
        {
            var produtoAteracao = new ProdutoViewModel
            {
                Id = UcProdutoVm.Id,
                Nome = UcProdutoVm.Nome,
                Valor = UcProdutoVm.Valor
            };

            new ProdutoBusiness().Alterar(produtoAteracao);
            CarregarRegistros();
        }

        private void RemoverProduto(long id)
        {
            var resultado = MessageBox.Show("Tem certeza de deseja remover o Produto?", "Atenção", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (resultado == MessageBoxResult.Yes)
            {
                new ProdutoBusiness().Remover(id);
                CarregarRegistros();
                LimparCampos();
            }
        } 

        private void LimparCampos()
        {
            UcProdutoVm.Id = 0;
            UcProdutoVm.Nome = "";
            UcProdutoVm.Valor = 0;
            UcProdutoVm.Alteracao = false;
        }

        private bool ValidarProduto()
        {
            if (string.IsNullOrEmpty(UcProdutoVm.Nome))
            {
                MessageBox.Show("O campo nome é obrigatorio.", "Atenção", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;            
            }
            return true;
        }

        
    }
}

