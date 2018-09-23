namespace Physics
{
    internal class DataToCalc
    {
        public double Force, Time, Acceleration, Speed, Distance, InitialDistance, InitialSpeed, Mass, Density, Volume, Pressure, Square, ArhForce, Height;

        public DataToCalc(double force, double time, double acceleration, double speed, double distance, double initialDistance, double initialSpeed, double mass, double density, double volume, double pressure, double square, double arhforce, double height)
        {
            this.Force = force;
            this.Time = time;
            this.Acceleration = acceleration;
            this.Speed = speed;
            this.Distance = distance;
            this.InitialDistance = initialDistance;
            this.InitialSpeed = initialSpeed;
            this.ArhForce = arhforce;
            this.Density = density;
            this.Height = height;
            this.Mass = mass;
            this.Pressure = pressure;
            this.Square = square;
            this.Volume = volume;
        }
    }
}