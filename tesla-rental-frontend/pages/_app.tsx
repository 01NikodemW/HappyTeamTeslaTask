import "@/styles/globals.css";
import { theme } from "@/theme/theme-options";
import ThemeProvider from "@mui/system/ThemeProvider";
import type { AppProps } from "next/app";

export default function App({ Component, pageProps }: AppProps) {
  return (
    <ThemeProvider theme={theme}>
      <Component {...pageProps} />
    </ThemeProvider>
  );
}
