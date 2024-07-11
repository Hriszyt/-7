def main():
    n = int(input())
    cars = {}

    
    for _ in range(n):
        car_data = input().split("|")
        car = car_data[0]
        mileage = int(car_data[1])
        fuel = int(car_data[2])
        cars[car] = {"mileage": mileage, "fuel": fuel}

    while True:
        command = input()
        if command == "Stop":
            break
        
        command_parts = command.split(": ")
        action = command_parts[0]
        car = command_parts[1]

        if action == "Drive":
            distance = int(command_parts[2])
            fuel_needed = int(command_parts[3])
            if cars[car]["fuel"] < fuel_needed:
                print("Not enough fuel to make that ride")
            else:
                cars[car]["mileage"] += distance
                cars[car]["fuel"] -= fuel_needed
                print(f"{car} driven for {distance} kilometers. {fuel_needed} liters of fuel consumed.")
                if cars[car]["mileage"] >= 100000:
                    print(f"Time to sell the {car}!")
                    del cars[car]

        elif action == "Refuel":
            fuel_amount = int(command_parts[2])
            max_fuel = 75
            current_fuel = cars[car]["fuel"]
            fuel_to_add = min(fuel_amount, max_fuel - current_fuel)
            cars[car]["fuel"] += fuel_to_add
            print(f"{car} refueled with {fuel_to_add} liters")

        elif action == "Revert":
            kilometers = int(command_parts[2])
            if cars[car]["mileage"] - kilometers < 10000:
                cars[car]["mileage"] = 10000
            else:
                cars[car]["mileage"] -= kilometers
                print(f"{car} mileage decreased by {kilometers} kilometers")

    
    for car, data in cars.items():
        print(f"{car} -> Mileage: {data['mileage']} kms, Fuel in the tank: {data['fuel']} lt.")

if __name__ == "__main__":
    main()
