import { createBrowserRouter } from "react-router-dom";

import { ProductsPage } from "./Products";
import { BusketPage } from "./Busket";
import { HomePage } from "./Home";
import { Blog } from "./Blog/ui";
import { AccountPage } from "./Account/ui";
import { AuthorizationPage } from "./Authorization";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <HomePage />,
  },
  {
    path: "/delivery",
    element: <HomePage />,
  },
  {
    path: "/products",
    element: <ProductsPage />,
  },
  {
    path: "/busket",
    element: <BusketPage />,
  },
  {
    path: "/blog",
    element: <Blog />,
  },
  {
    path: "/account",
    element: <AccountPage />,
  },
  {
    path: "/authorization",
    element: <AuthorizationPage />,
  },
]);
