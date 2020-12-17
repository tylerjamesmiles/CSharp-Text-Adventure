class Vector2
{
    public int x, y;
    public Vector2(int _x, int _y)
    {
        x = _x;
        y = _y;
    }
    public Vector2(Vector2 v)
    {
        x = v.x;
        y = v.y;
    }

    public double Mag()
    => (x + y) / 2;

    public static Vector2 operator +(Vector2 v1, Vector2 v2)
        => new Vector2(v1.x + v2.x, v1.y + v2.y);
    public static Vector2 operator -(Vector2 v1, Vector2 v2)
        => new Vector2(v1.x - v2.x, v1.y - v2.y);



    public override bool Equals(object obj)
    {
        if (obj == null || !this.GetType().Equals(obj.GetType()))
            return false;

        Vector2 v = (Vector2)obj;
        return (v.x == x && v.y == y);
    }
}


