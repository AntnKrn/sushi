import React from "react";

import { Logo } from "../../../shared/ui/icons/logo";
import "./index.scss";
import { MapPoint } from "../../../shared/ui/icons/mapPoint";
import { Clock } from "../../../shared/ui/icons/clock";
import { Email } from "../../../shared/ui/icons/email";
import { Phone } from "../../../shared/ui/icons/phone";

export const Contacts = () => {
  return (
    <div className="Contacts">
      <div className="contact item side left">
        <h6>
          <Clock />
          &nbsp;10:00-22:00
        </h6>
        <h6>
          <MapPoint />
          Mira str., Minsk
        </h6>
      </div>
      <div className="contact item center">
        <a href="/">
          <Logo />
        </a>
      </div>
      <div className="contact item side right">
        <h6>
          <Email />
          krnant@icloud.com
        </h6>
        <h6>
          <Phone />
          +375201830403
        </h6>
      </div>
    </div>
  );
};
