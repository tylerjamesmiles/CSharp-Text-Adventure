class Player
{
    public Vector2 vPos;
    public Player(Vector2 pos)
    {
        vPos = pos;
    }

    public void Move(Vector2 by)
    {
        vPos = vPos + by;
    }
}
