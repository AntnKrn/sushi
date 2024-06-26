import { createBrowserRouter } from "react-router-dom";

import { ProductsPage } from "./Products";
import { BusketPage } from "./Busket";
import { HomePage } from "./Home";
import { Blog } from "./Blog/ui";
import { DeliveryPage } from "./Delivery/ui";
import { ContactsPage } from "./Сontacts/ui";
import { AuthorizationPage } from "./Authorization/ui";
import { AccountPage } from "./Account/ui";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <HomePage />,
  },
  {
    path: "/delivery",
    element: <DeliveryPage />,
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
    path: "/contacts",
    element: <ContactsPage />,
  },
  {
    path: "/authorization",
    element: <AuthorizationPage />,
  },
  {
    path: "/account",
    element: <AccountPage />,
  },
]);
