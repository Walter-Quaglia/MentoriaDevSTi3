using MentoriaDevSTi3.Business;
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
            FinalizarPedido();
        }

        private void InicializarOperacao()
        {
            DataContext = UcPedidoVm;

            UcPedidoVm.ListaClientes = new ObservableCollection<ClienteViewModel>(new ClienteBusiness().Listar());
            UcPedidoVm.ListaProdutos = new ObservableCollection<ProdutoViewModel>(new ProdutoBusiness().Listar());

            UcPedidoVm.ListaPagamentos = new ObservableCollection<string>
            {
                "Dinheiro",
                "Boleto",
                "Cartão de Crédito",
                "Cartão de Débito",
                "PIX"
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
                ValorTotalItem = UcPedidoVm.Quantidade * UcPedidoVm.ValorUnit,
                ProdutoId = produtoSelecionado.Id
            };

            UcPedidoVm.ItensAdicionados.Add(itemVm);

            UcPedidoVm.ValorTotalPedido = UcPedidoVm.ItensAdicionados.Sum(i => i.ValorTotalItem);

            LimparCamposProduto();
        }

        private void LimparCamposProduto()
        {
            UcPedidoVm.Quantidade = 1;
            CmbProduto.SelectedItem = null;
            UcPedidoVm.ValorUnit = 0;
        }

        private void LimparTodosCampos()
        {
            UcPedidoVm.ItensAdicionados = new ObservableCollection<UcPedidoItemViewModel>();
            UcPedidoVm.ValorTotalPedido = 0;
            CmbCliente.SelectedItem = null;
            CmbFormaPagamento.SelectedItem = null;

            LimparCamposProduto();
        }

        private void FinalizarPedido()
        {
            var clienteSelecionado = CmbCliente.SelectedItem as ClienteViewModel;
            var formaPagamentoSelecionada = CmbFormaPagamento.SelectedItem as string;

            var pedidoViewModel = new PedidoViewModel
            {
                ClienteId = clienteSelecionado.Id,
                FormaPagamento = formaPagamentoSelecionada,
                Valor = UcPedidoVm.ValorTotalPedido,
                ItensPedido = UcPedidoVm.ItensAdicionados.Select(s => new ItensPedidoViewModel
                {
                    ProdutoId = s.ProdutoId,
                    Quantidade = s.Quantidade,
                    Valor = s.ValorTotalItem
                }).ToList()
            };

            new PedidoBusiness().Adicionar(pedidoViewModel);

            MessageBox.Show("Pedido realizado com sucesso!", "Sucesso!", MessageBoxButton.OK, MessageBoxImage.Information);

            LimparTodosCampos();
        }
    }
}