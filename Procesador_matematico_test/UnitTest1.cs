using Xunit;
using primer_parcial_unit_test_procesador_matematico;
using System;

namespace Procesador_matematico_test
{
    public class UnitTest1
    {
     
         [Fact]
         public void SumaTest__un_parametro_negativo()
         {

           ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 0;

            procesadorMatematico.Sumar(0, -1);
            int resultadoReal = procesadorMatematico.getResultado();

            Assert.Equal(resultadoEsperado, resultadoReal);

         }

        [Fact]
        public void SumaTest__dos_parametro_negativo()
        {

            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 0;

            procesadorMatematico.Sumar(-1, -1);
            int resultadoReal = procesadorMatematico.getResultado();

            Assert.Equal(resultadoEsperado, resultadoReal);

        }


        [Fact]
        public void divisionTest__dividir_por_cero()
        {

            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();


            
            try
            {
                procesadorMatematico.Dividir(12, 0);
            }
            catch (DivideByZeroException ex)
            {
                Assert.True(true);
                return;
            }
            Assert.True(false);

        }

        [Fact]
        public void divisionTest__divisor_negativo()
        {

            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 0;

            procesadorMatematico.Dividir(12, -1);
            int resultadoReal = procesadorMatematico.getResultado();

            Assert.Equal(resultadoEsperado, resultadoReal);

        }

        [Fact]
        public void divisionTest__dividendo_negativo()
        {

            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 0;

            procesadorMatematico.Dividir(-12, 1);
            int resultadoReal = procesadorMatematico.getResultado();

            Assert.Equal(resultadoEsperado, resultadoReal);

        }

        [Fact]
        public void CalcularMayorTest__primer_parametro_mayor()
        {

            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 12;

            procesadorMatematico.CalcularMayor(12, 0);
            int resultadoReal = procesadorMatematico.getResultado();

            Assert.Equal(resultadoEsperado, resultadoReal);

        }

        [Fact]
        public void CalcularMayorTest__segundo_parametro_mayor()
        {

            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 12;

            procesadorMatematico.CalcularMayor(0, 12);
            int resultadoReal = procesadorMatematico.getResultado();

            Assert.Equal(resultadoEsperado, resultadoReal);

        }

        [Fact]
        public void CalcularMayorTest__parametros_Iguales()
        {

            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 12;

            procesadorMatematico.CalcularMayor(12, 12);
            int resultadoReal = procesadorMatematico.getResultado();

            Assert.Equal(resultadoEsperado, resultadoReal);

        }

        [Fact]
        public void CalcularMayorTest__numero_negativo()
        {

            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            int resultadoEsperado = 12;

            procesadorMatematico.CalcularMayor(12, -12);
            int resultadoReal = procesadorMatematico.getResultado();

            Assert.Equal(resultadoEsperado, resultadoReal);

        }




    }
}