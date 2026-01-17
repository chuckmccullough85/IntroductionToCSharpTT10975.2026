namespace PaywizUI;

public abstract class View<M> (M model)
{
    public M Model { get; init; } = model;
    public abstract void Display();
}
