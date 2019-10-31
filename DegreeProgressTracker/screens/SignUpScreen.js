import React, { useState } from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, TextInput, ImageBackground, KeyboardAvoidingView } from 'react-native';
import Axios from 'axios';

// inital state of sign up fields
const SignUp = props => {
    const [signUpInputs] = useState({
        FirstName: "",
        LastName: "",
        Username: "",
        Emali: "",
        Password: "",
        ConfirmPassword: ""
    })

    //sign up handlers
    const firstNameChangeHandler = (event) => {
        signUpInputs.FirstName = event.target.value;
    }
    const lastNameChangeHandler = (event) => {
        signUpInputs.LastName = event.target.value;
    }
    const userNameChangeHandler = (event) => {
        signUpInputs.UserName = event.target.value;
    }
    const emailChangeHandler = (event) => {
        signUpInputs.Email = event.target.value;
    }
    const passwordChangeHandler = (event) => {
        signUpInputs.Password = event.target.value;
    }
    const confirmPasswordChangeHandler = (event) => {
        signUpInputs.ConfirmPassword = event.target.value;
    }

    const createUserAndNavigate = () => {
        createUser();
        props.navigation.navigate({ routeName: 'TestScreen' });
    }

    const createUser = () => {
        Axios.post('http://localhost:50854/Users', signUpInputs)

            .then(function (response) {
                console.log(response)
                signUpInputs.FirstName = '';
                signUpInputs.LastName = '';
                signUpInputs.Username = '';
                signUpInputs.Email = '';
                signUpInputs.Password = '';
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
                        secureTextEntry={true}
                        placeholder=" Password"
                        style={styles.input}
                        onChange={passwordChangeHandler}
                    />

                    <TextInput
                        secureTextEntry={true}
                        placeholder=" Confirm Password"
                        style={styles.input}
                        onChange={confirmPasswordChangeHandler}
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