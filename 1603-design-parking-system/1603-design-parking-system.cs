public class ParkingSystem {

    private int _big;
    private int _medium;
    private int _small;
    
    public ParkingSystem(int big, int medium, int small) {
        _big = big;
        _medium = medium;
        _small = small;
    }
    
    public bool AddCar(int carType) {
        
        return carType switch
        {
                1 => --_big >= 0 ? true : false,
                2 => --_medium >= 0 ? true : false,
                3 => --_small >= 0 ? true : false
        };
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */