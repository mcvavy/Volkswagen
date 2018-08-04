export interface Response {
  fuelType: string;
  makeModel: string;
  model: string;
  transmission: string;
  colour: string;
  dateFirstRegistered: string;
  vehicleClass: string;
  transmissionType: string;
  make: string;
  vrm: string;
  dateFirstRegisteredUk: any;
  co2Emissions: number;
  engineCapacity: string;
  yearOfManufacture: string;
  response: ResponseObject;
}

export interface ResponseObject {
  statusCode: string;
  statusMessage: string;
}
