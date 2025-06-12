namespace TrabalhoArquiteturaDIP
{ 
    public class Lamp : IOperableDevice
    {
        private StateEnum _state = StateEnum.Off;

        public void Operate()
        {
            _state = _state == StateEnum.On ? StateEnum.Off : StateEnum.On;
            Console.WriteLine("Luz " + (_state == StateEnum.On ? "Ligada" : "Desligada"));
        }
    }
}
