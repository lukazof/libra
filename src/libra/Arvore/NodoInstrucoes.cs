namespace Libra.Arvore
{
    public abstract class NodoInstrucao : Nodo {} // Por que não interface? Não me pergunte

    public class NodoInstrucaoSair : NodoInstrucao
    {
        public NodoInstrucaoSair(NodoExpressao expressao)
        {
            Expressao = expressao;
        }

        public NodoExpressao Expressao { get; private set; }

        public override object Avaliar()
        {
            return Expressao.Avaliar();
        }
    }

    public class NodoInstrucaoVar : NodoInstrucao
    {
        public NodoInstrucaoVar(Var var)
        {
            m_var = var;
        }

        private Var m_var;

        public override object Avaliar()
        {
            return m_var;
        }
    }

    public class NodoInstrucaoImprimir: NodoInstrucao
    {
        public NodoInstrucaoImprimir(NodoExpressao expressao)
        {
            m_expressao = expressao;
        }

        private NodoExpressao m_expressao;

        public override object Avaliar()
        {
            return m_expressao;
        }
    }
}