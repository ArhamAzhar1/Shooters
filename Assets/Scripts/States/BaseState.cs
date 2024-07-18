public abstract class Basestate
{
    public StateMachine stateMachine;

    public abstract void Enter();
    public abstract void Perform();
    public abstract void Exit();
}