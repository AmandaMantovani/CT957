using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Teste()
        {
            Voo voo1 = new Voo("Teste ada", 150, DateTime.Now);

            Assert.Equal(100, voo1.QuantidadeVagasDisponivel());

            Assert.Equal(0, voo1.ProximoLivre());
            voo1.OcuparAssento(1);

            Assert.Equal(0, voo1.ProximoLivre());
            voo1.OcuparAssento(0);
            voo1.OcuparAssento(5);
            voo1.OcuparAssento(2);
            voo1.OcuparAssento(15);

            Assert.Equal(3, voo1.ProximoLivre());

            Assert.Equal(95, voo1.QuantidadeVagasDisponivel());

            Assert.False(voo1.AssentoDisponivel(1));
            Assert.False(voo1.AssentoDisponivel(15));
            Assert.True(voo1.AssentoDisponivel(30));


        }

        [Fact]
        public void Teste2()
        {
            Voo voo1 = new Voo("Teste ada", 150, DateTime.Now);

            Assert.Equal(100, voo1.QuantidadeVagasDisponivel());

            voo1.OcuparAssento(1);

            Assert.Equal(0, voo1.ProximoLivre());
            voo1.OcuparAssento(0);
            voo1.OcuparAssento(5);
            voo1.OcuparAssento(2);
            voo1.OcuparAssento(15);

            Assert.Equal(3, voo1.ProximoLivre());

            Assert.Equal(95, voo1.QuantidadeVagasDisponivel());

            Assert.False(voo1.AssentoDisponivel(1));
            Assert.False(voo1.AssentoDisponivel(15));
            Assert.True(voo1.AssentoDisponivel(30));


        }
    }
}