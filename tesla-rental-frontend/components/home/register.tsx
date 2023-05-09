import {
  Autocomplete,
  Box,
  Button,
  Snackbar,
  TextField,
  Typography,
} from "@mui/material";
import React, { FC, useEffect, useState } from "react";
import { DisabledButtonStyle, InputStyle } from "@/styles/input-style";
import { useFormik } from "formik";

interface RegisterProps {
  setLogin: () => void;
}

type Country = {
  id: string;
  name: string;
};

export const Register: FC<RegisterProps> = (props) => {
  const { setLogin } = props;
  const [countries, setCountries] = useState<Country[]>([]);
  const [selectedCountry, setSelectedCountry] = useState<Country | null>(null);
  const handleCountryChange = (event: any, newValue: Country | null) => {
    setSelectedCountry(newValue);
  };
  const [isSnackbarOpen, setIsSnackbarOpen] = useState<boolean>(false);
  const [snackbarMessage, setSnackbarMessage] = useState<string>("");

  useEffect(() => {
    async function getCountries() {
      const response = await fetch("http://localhost:5070/Country", {
        method: "GET",
        mode: "cors",
        headers: {
          "Content-Type": "application/json",
          "Access-Control-Allow-Origin": "http://localhost:3000",
        },
      });
      if (!response.ok) {
        return;
      }
      const data = await response.json();
      setCountries(data);
    }
    getCountries();
  }, []);

  type formikTypes = {
    email: string;
    password: string;
    confirmPassword: string;
    fistName: string;
    lastName: string;
  };

  const initialValues: formikTypes = {
    email: "",
    password: "",
    confirmPassword: "",
    fistName: "",
    lastName: "",
  };

  const formik = useFormik({
    initialValues,
    onSubmit: (values) => {
      const registerData = {
        email: values.email,
        password: values.password,
        passwordConfirmation: values.confirmPassword,
        firstName: values.fistName,
        lastName: values.lastName,
        countryId: selectedCountry?.id,
      };

      async function register() {
        const response = await fetch("http://localhost:5070/User/Register", {
          method: "POST",
          mode: "cors",
          headers: {
            "Content-Type": "application/json",
            "Access-Control-Allow-Origin": "http://localhost:3000",
          },
          body: JSON.stringify(registerData),
        });
        if (!response.ok) {
          setIsSnackbarOpen(true);
          setSnackbarMessage(await response.text());
          return;
        }
        setLogin();
      }
      register();
    },
  });

  const handleSnackbarClose = () => {
    setIsSnackbarOpen(false);
    setSnackbarMessage;
  };

  const isButtonDisabled =
    formik.values.email === "" ||
    formik.values.password === "" ||
    formik.values.confirmPassword === "" ||
    formik.values.fistName === "" ||
    formik.values.lastName === "" ||
    selectedCountry === null;

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
          Register
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
          name="password"
          sx={InputStyle}
          value={formik.values.password}
          onChange={formik.handleChange}
        />
        <TextField
          label="Confirm password"
          type="password"
          name="confirmPassword"
          sx={InputStyle}
          value={formik.values.confirmPassword}
          onChange={formik.handleChange}
        />
        <TextField
          label="First Name"
          name="fistName"
          sx={InputStyle}
          value={formik.values.fistName}
          onChange={formik.handleChange}
        />
        <TextField
          label="Last Name"
          name="lastName"
          sx={InputStyle}
          value={formik.values.lastName}
          onChange={formik.handleChange}
        />
        <Autocomplete
          value={selectedCountry}
          onChange={handleCountryChange}
          options={countries}
          getOptionLabel={(option) => option.name}
          renderInput={(params) => <TextField {...params} label="Country" />}
          sx={{
            width: "70%",
            "& .MuiOutlinedInput-root": {
              "& fieldset": {
                borderColor: "#ffffff",
              },
              "&:hover fieldset": {
                borderColor: "#ffffff",
              },
              "&.Mui-focused fieldset": {
                borderColor: "#ffffff",
              },
            },
            "& .MuiOutlinedInput-input": {
              color: "#ffffff",
            },
            "& .MuiInputLabel-root": {
              color: "#fff",
            },
            mb: 2,
          }}
        />

        <Button
          variant="contained"
          type="submit"
          disabled={isButtonDisabled}
          sx={DisabledButtonStyle}
        >
          Register
        </Button>
        <Button
          sx={{
            color: "white",
          }}
          onClick={setLogin}
        >
          Already havea an account? Login
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
