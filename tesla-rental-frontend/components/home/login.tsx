import { Box, Button, Snackbar, TextField, Typography } from "@mui/material";
import { useFormik } from "formik";
import React, { FC, useState } from "react";
import { InputStyle } from "@/styles/input-style";
import { DisabledButtonStyle } from "@/styles/input-style";

interface LoginProps {
  setRegister: () => void;
  setNone: () => void;
}

export const Login: FC<LoginProps> = (props) => {
  const { setRegister, setNone } = props;
  const [isSnackbarOpen, setIsSnackbarOpen] = useState<boolean>(false);
  const [snackbarMessage, setSnackbarMessage] = useState<string>("");

  type formikTypes = {
    email: string;
    password: string;
  };

  const initialValues: formikTypes = {
    email: "",
    password: "",
  };

  const formik = useFormik({
    initialValues,
    onSubmit: (values) => {
      const loginData = {
        email: values.email,
        password: values.password,
      };

      async function login() {
        const response = await fetch("http://localhost:5070/User/Login", {
          method: "POST",
          mode: "cors",
          headers: {
            "Content-Type": "application/json",
            "Access-Control-Allow-Origin": "http://localhost:3000",
          },
          body: JSON.stringify(loginData),
        });
        if (!response.ok) {
          setIsSnackbarOpen(true);
          setSnackbarMessage("Wrong email or password");
          return;
        }

        const data = await response.text();
        localStorage.setItem("token", data);
        setNone();
      }
      login();
    },
  });

  const handleSnackbarClose = () => {
    setIsSnackbarOpen(false);
    setSnackbarMessage("");
  };

  const isButtonDisabled =
    formik.values.email === "" || formik.values.password === "";
  return (
    <form onSubmit={formik.handleSubmit}>
      <Box
        sx={{
          border: "2px solid white",
          display: "flex",
          borderRadius: "10px",
          flexDirection: "column",
          alignItems: "center",
          padding: "20px",
        }}
      >
        <Typography variant="h5" sx={{ mb: 2 }}>
          Login
        </Typography>
        <TextField
          label="Email"
          sx={InputStyle}
          name="email"
          value={formik.values.email}
          onChange={formik.handleChange}
        />
        <TextField
          label="Password"
          type="password"
          sx={InputStyle}
          name="password"
          value={formik.values.password}
          onChange={formik.handleChange}
        />

        <Button
          variant="contained"
          disabled={isButtonDisabled}
          type="submit"
          sx={DisabledButtonStyle}
        >
          Login
        </Button>
        <Button
          sx={{
            color: "white",
          }}
          onClick={setRegister}
        >
          Don't have account? Register
        </Button>
        <Snackbar
          open={isSnackbarOpen}
          autoHideDuration={6000}
          onClose={handleSnackbarClose}
          message={snackbarMessage}
        />
      </Box>
    </form>
  );
};
