using MentoriaDevSTi3.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace MentoriaDevSTi3.View.UserControls
{
    /// <summary>
    /// Interaction logic for UcPedido.xaml
    /// </summary>
    public partial class UcPedido : UserControl
    {
        private UcPedidoViewModel UcPedidoVm = new UcPedidoViewModel();

        public UcPedido()
        {
            InitializeComponent();

            InicializarOperacao();
        }

        private void CmbProduto_DropDownClosed(object sender, EventArgs e)
        {
            if (sender is ComboBox cmb && cmb.SelectedItem is ProdutoViewModel produto)
            {
                UcPedidoVm.ValorUnit = produto.Valor;
            }
        }

        private void BtnAdicionarItem_Click(object sender, RoutedEventArgs e)
        {
            AdicionarItem();
        }

        private void BtnFinalizarPedido_Click(object sender, RoutedEventArgs e)
        {

        }

        private void InicializarOperacao()
        {
            DataContext = UcPedidoVm;

            UcPedidoVm.ListaClientes = new ObservableCollection<ClienteViewModel>
            {
                new ClienteViewModel { Nome = "Cliente 1" },
                new ClienteViewModel { Nome = "Cliente 2" }
            };

            UcPedidoVm.ListaProdutos = new ObservableCollection<ProdutoViewModel>
            {
                new ProdutoViewModel{ Nome = "Produto 1", Valor = 10 },
                new ProdutoViewModel{ Nome = "Produto 2", Valor = 20 },
            };

            UcPedidoVm.ListaPagamentos = new ObservableCollection<string>
            {
                "Dinheiro",
                "Boleto",
                "Cartão de Crédito",
                "Cartão de Débito",
                "PIX",
            };

            UcPedidoVm.Quantidade = 1;
            UcPedidoVm.ItensAdicionados = new ObservableCollection<UcPedidoItemViewModel>();
        }

        private void AdicionarItem()
        {
            var produtoSelecionado = CmbProduto.SelectedItem as ProdutoViewModel;

            var itemVm = new UcPedidoItemViewModel
            {
                Nome = produtoSelecionado.Nome,
                Quantidade = UcPedidoVm.Quantidade,
                ValorUnit = UcPedidoVm.ValorUnit,
                ValorTotalItem = UcPedidoVm.Quantidade * UcPedidoVm.ValorUnit
            };

            UcPedidoVm.ItensAdicionados.Add(itemVm);

            UcPedidoVm.ValorTotalPedido = UcPedidoVm.ItensAdicionados.Sum(i => i.ValorTotalItem);
        }

    }
}