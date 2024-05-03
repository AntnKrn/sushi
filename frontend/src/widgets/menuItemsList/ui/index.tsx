import React from "react";
import { MenuItem } from "../../../entities/menuItem";
import "./index.scss";
import { IMenu, search } from "../../../shared/api";

interface IProps {
  data: IMenu[];
}

export const MenuItemsList = ({ data }: IProps) => {
  return (
    <div>
      <h1 id="chosen-name">Выбор дня</h1>
      <div className="menu-items-list">
        {data.map((item, index) => {
          return (
            <MenuItem
              key={index}
              name={item.name}
              ingredients={item.ingredients}
              price={item.price}
            />
          );
        })}
      </div>
    </div>
  );
};
