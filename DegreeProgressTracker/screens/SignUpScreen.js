import React, { useState } from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, TextInput, ImageBackground, KeyboardAvoidingView } from 'react-native';
import Axios from 'axios';
import AppSettings from "../AppSettings"

// inital state of sign up fields
const SignUp = props => {
    var [signUpInputs] = useState({
        firstName: "",
        lastName: "",
        username: "",
        email: "",
        startYear: 0,
        password: "",
    })

    //sign up handlers
    const firstNameChangeHandler = (event) => {
        signUpInputs.firstName = event.nativeEvent.text;
    }
    const lastNameChangeHandler = (event) => {
        signUpInputs.lastName = event.nativeEvent.text;
    }
    const userNameChangeHandler = (event) => {
        signUpInputs.username = event.nativeEvent.text;
    }
    const emailChangeHandler = (event) => {
        signUpInputs.email = event.nativeEvent.text;
    }
    const startYearChangeHandler = (event) => {
        signUpInputs.startYear  = parseInt(event.nativeEvent.text);
    }
    const passwordChangeHandler = (event) => {
        signUpInputs.password = event.nativeEvent.text;;
    }
    /*
    const confirmPasswordChangeHandler = (event) => {
        signUpInputs.ConfirmPassword = event.nativeEvent.text;
    }
    */


    const createUserAndNavigate = () => {
        createUser();
        props.navigation.navigate({ routeName: 'CourseCategories' });
    }

    const createUser = () => {
        const url = `${AppSettings.baseUrl}/Users`;
        Axios.post(url, signUpInputs)

            .then(function (response) {
                console.log(response)
                signUpInputs.firstName;
                signUpInputs.lastName;
                signUpInputs.username;
                signUpInputs.email;
                signUpInputs.startYear;
                signUpInputs.password;
            })
            .catch(function (error) {
                console.log(error);
            });
    }

    return (

        <ImageBackground
            style={{
                flex: 1,
                position: 'absolute',
                width: '100%',
                height: '100%',
                justifyContent: 'center',
            }}
            source={require('../assets/Background.png')}
        >

            <View style={styles.container}>

                <View>

                    <Text style={styles.title}>Sign Up</Text>

                </View>

                <KeyboardAvoidingView style={styles.inputContainer} behavior="padding">

                    <TextInput
                        placeholder=" First name"
                        style={styles.input}
                        onChange={firstNameChangeHandler}
                    />

                    <TextInput
                        placeholder=" Last name"
                        style={styles.input}
                        onChange={lastNameChangeHandler}
                    />

                    <TextInput
                        placeholder=" Username"
                        style={styles.input}
                        onChange={userNameChangeHandler}
                    />

                    <TextInput
                        placeholder=" Email"
                        style={styles.input}
                        onChange={emailChangeHandler}
                    />

                    <TextInput
                        placeholder=" Start year"
                        style={styles.input}
                        onChange={startYearChangeHandler}
                    />

                    <TextInput
                        secureTextEntry={true}
                        placeholder=" Password"
                        style={styles.input}
                        onChange={passwordChangeHandler}
                    />

                    <TextInput
                        secureTextEntry={true}
                        placeholder=" Confirm Password"
                        style={styles.input}
                       // onChange={confirmPasswordChangeHandler}
                    />


                    <View style={styles.button}><TouchableOpacity><Button title="Sign Up" color='grey' 
                        onPress={() => {
                            createUserAndNavigate();
                        }}
                        /></TouchableOpacity></View>

                    <View style={styles.button}><TouchableOpacity><Button title="Log In" color='grey' onPress={() => {
                        props.navigation.navigate({ routeName: 'LogIn' });
                    }} /></TouchableOpacity></View>

                    <View style={{ height: 145 }} />
                </KeyboardAvoidingView>
            </View>

        </ImageBackground>
    );

};

const styles = StyleSheet.create({

    container: {
        height: '100%',
        width: '100%',
        //backgroundColor: '#1E8449',
        justifyContent: 'space-between',

    },
    title: {
        fontSize: 35,
        textAlign: "center",
        color: 'black',
        paddingTop: 100,
        //fontFamily: 'Helvetica',
    },
    inputContainer: {
        alignItems: 'center',
        paddingBottom: 250,
    },
    input: {
        height: 35,
        width: '80%',
        marginBottom: 10,
        borderWidth: 1,
        alignItems: 'center',
    },
    button: {
        width: '80%',
        paddingBottom: 15,
    }
});

export default SignUp;