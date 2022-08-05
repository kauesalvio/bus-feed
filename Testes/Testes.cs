using FluentAssertions;
using PROVA_DE_SUFICIENCIA;
using PROVA_DE_SUFICIENCIA.Entities;
using System;
using Xunit;

namespace Testes
{
    public class Testes
    {
        /// <summary>
        /// Kauê Felipe Salvio
        /// </summary>
        [Fact]
        public void Validar_Campos_Deve__Lancar_Excecao()
        {
            //Arrange
            var municipal = new Municipal("CCC-2222", "Gilberto", DateTime.Now, new TimeOnly(00, 00));
            var cadastro = new Cadastro(municipal);
            cadastro.txtNome.Text = "Gilberto";
            cadastro.mskTxtRg.Text = "12345678";
            cadastro.mskTxtTelefone.Text = "32 99999-9999";
            cadastro.checkIdoso.Checked = true;
            cadastro.comboBox1.SelectedItem = "38";

            //Act
            var result = Record.Exception(() => cadastro.ValidarCampos());

            //Assert
            result.Should().BeOfType<ArgumentException>();
            result.Message.Should().Be("Usuário inválido!");
        }

        [Fact]
        public void Validar_Campos_Nao_Deve_Lancar_Excecao()
        {
            //Arrange
            var municipal = new Municipal("BBB-8888", "Claudio", DateTime.Now, new TimeOnly(00, 00));
            var cadastro = new Cadastro(municipal);
            cadastro.txtNome.Text = "Claudio";
            cadastro.mskTxtRg.Text = "743867534";
            cadastro.mskTxtTelefone.Text = "27 88888-9999";
            cadastro.checkIdoso.Checked = true;
            cadastro.comboBox1.SelectedItem = "60";

            //Act
            var result = Record.Exception(() => cadastro.ValidarCampos());

            //Assert
            result.Should().BeNull();
        }
        [Fact]
        public void Municipal_Deve_Lancar_Excecao()
        {
            //Arrange
            var municipal = new Municipal("CCC-6666", "Claudinei", DateTime.Now, new TimeOnly(00, 00));
            var listPassageiro = new PassageiroFalso().Generate(36);
            Exception result = null;

            //Act
            foreach (var item in listPassageiro)
                result = Record.Exception(() => municipal.AddPassageiro(item));


            //Assert
            result.Should().BeOfType<ArgumentException>();
            result.Message.Should().Be("Vagas totais de passageiros atingido! ");
        }

        [Fact]
        public void Intermunicipal_Deve_Lancar_Excecao()
        {
            //Arrange
            var interMunicipal = new Intermunicipal("DDD-1111", "Roberto", DateTime.Now, new TimeOnly(00, 00));
            var listPassageiro = new PassageiroFalso().Generate(3);

            //Act
            foreach (var item in listPassageiro)
                interMunicipal.AddPassageiro(item);

            var result = interMunicipal.GetValorTotal();

            //Assert
            result.Should().BeGreaterThan(29.83f);
            result.Should().BeLessThan(29.85f);
        }
    }
}