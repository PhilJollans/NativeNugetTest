namespace WrapperDll
{
  public class HelloWorld
  {
    public void SayHello()
    {
      NativeMethods.HelloWorld();
    }
  }
}
