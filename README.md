1. Pobierz listę listę wszystkich samochodów
  GET api/vehicles

2. Pobierz samochód o podanym Id
  GET api/vehicles/id

3. Stwórz nowy pojazd
  POST api/vehicles
  
  {
    "brand": "wpisz markę",
    "model": "wpisz model",
    "seats": ilość miejsc
  }

4. Usuń pojaz o podanym Id
  DELETE api/vehicles/id
