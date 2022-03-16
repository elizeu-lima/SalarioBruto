using System;
using System.Globalization;

namespace SalarioBruto{
    class Funcionario{
        public string? Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem){
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }
        public override string ToString(){
           return Nome
           + " , Salário Liquido: R$ "
           + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
