import { createBrowserRouter } from "react-router-dom";

import { ProductsPage } from "./Products";
import { BusketPage } from "./Busket/ui";

export const router = createBrowserRouter([
  {
    path: "/products",
    element: <ProductsPage />,
  },
  {
    path: "/busket",
    element: <BusketPage />,
  },
]);
