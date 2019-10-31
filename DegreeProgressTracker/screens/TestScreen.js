import React, { useState } from 'react';
import Axios from 'axios';
import { Button, StyleSheet, Text, TextInput, TouchableOpacity, View, ImageBackground } from 'react-native';

const TestScreen = props => { 
    const [loginInputs] = useState({
        Username: "",
        Password: ""
    })


    //login handlers
    const usernameChangeHandler = (event) => {
        loginInputs.Username = event.target.value;
    }
    const passwordChangeHandler = (event) => {
        loginInputs.Password = event.target.value;
    }


    const testCreateUser = () => {
        Axios.get('http://localhost:50854/Users')

            .then(res => {
                const userFirstName = res.data.FirstName;
                console.log(userFirstName);
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

            <View style={styles.container} >

                <View>
                    <Text style={styles.title}>Test Screen</Text>
                </View>

                <View style={styles.inputContainer}>
                    <TextInput
                        placeholder=" Test box"
                        onChange={usernameChangeHandler}
                        style={styles.input}
                    />

                    <TextInput
                        placeholder=" Password"
                        secureTextEntry={true}
                        onChange={passwordChangeHandler}
                        style={styles.input}
                    />
                </View>

                <View style={styles.buttonContainer}>

                    <View style={styles.button}><TouchableOpacity><Button title="Log In" color='grey' /></TouchableOpacity></View>

                    <View style={styles.button}><TouchableOpacity><Button title="Sign Up" color='grey' onPress={() => {
                        props.navigation.navigate({ routeName: 'SignUp' });
                    }} />
                    </TouchableOpacity></View>

                </View>

            </View>

        </ImageBackground>
    );

};

export default TestScreen;


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
    input: {
        height: 35,
        width: '80%',
        marginBottom: 10,
        borderWidth: 1,
        alignItems: 'center',
    },
    inputContainer: {
        paddingTop: 150,
        alignItems: 'center',
        justifyContent: 'center',
        width: '100%',
    },
    buttonContainer: {
        alignItems: 'center',
        width: '100%',
        paddingBottom: 200,
    },
    button: {
        width: '80%',
        paddingBottom: 15,
    }
});