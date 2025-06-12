namespace TrabalhoArquiteturaDIP
{
    public class Switch
    {
        private IOperableDevice _device;

        public void SetDevice(IOperableDevice device)
        {
            _device = device;
        }

        public void Press()
        {
            _device.Operate();
        }
    }
}