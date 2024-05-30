export function getCookieByName(name: string): string | undefined {
  const cookiesFromBrowser = document.cookie.split("; ");
  return cookiesFromBrowser.find((x: any) => x.split("=")[0] === name);
}

export function setCookieByNameAndValue(name: string, value: string): void {
  const newCookie = name + "=" + value;
  if (getCookieByName(name)) {
    const cookiesFromBrowser = document.cookie.split("; ");
    const indexOfCookie = cookiesFromBrowser.findIndex(
      (x) => x.split("=")[0] === name
    );
    cookiesFromBrowser[indexOfCookie] = newCookie;
  } else {
    document.cookie = newCookie;
  }
}
