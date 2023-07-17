public class Coordinates {
    int x, y;

    Coordinates(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public double countDistance(Coordinates coordinates) {
        int dx = coordinates.x - this.x;
        int dy = coordinates.y - this.y;
        return Math.sqrt(dx * dx + dy * dy);
    }
}
