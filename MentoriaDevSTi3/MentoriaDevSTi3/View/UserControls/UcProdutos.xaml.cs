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

            UcProdutoVm.ProdutosAdicionados = new ObservableCollection<ProdutoViewModel>();
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

        private void TxtValor_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void PreencherCampos(ProdutoViewModel produto)
        {
            UcProdutoVm.Nome = produto.Nome;
            UcProdutoVm.Valor = produto.Valor;

            UcProdutoVm.Alteracao = true;
        }
        
        private void AdicionarProduto()
        {
            var novoProduto = new ProdutoViewModel
            {
                Nome = UcProdutoVm.Nome,
                Valor = UcProdutoVm.Valor
            };

            UcProdutoVm.ProdutosAdicionados.Add(novoProduto);
        }

        private void AlterarProduto()
        {
            //será desenvolvido na aula de banco de dados
        }

        private void LimparCampos()
        {
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

