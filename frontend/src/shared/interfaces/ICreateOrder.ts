export interface ICreateOrder {
  clientId: number | null;
  date: Date;
  totalPrice: number;
  status: string;
  orderItems: {
    menuId: number;
    quantity: number;
    subSum: number;
  }[];
}
