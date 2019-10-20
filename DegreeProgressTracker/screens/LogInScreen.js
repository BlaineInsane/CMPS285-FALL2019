import React, { useState } from 'react';
import Axios from 'axios';
import { Button, StyleSheet, Text, TextInput, TouchableOpacity, View, ImageBackground } from 'react-native';
//export default class App extends React.Component {
//
//    constructor(props){
//        super(props);
//        this.state = {
//            isLoading: true,
//            dataSource: null,
//        }
//
//    }
//    componentDidMount() {
//
//        return fetch('http://localhost:50854/Users/authenticate')
//        .then((response)=> response.json())
//        .then((responseJson) =>{
//            this.setState({
//                isLoading: false,
//                dataSource: responseJson.authenticate
//            })
//        })
//        .catch((error)=> {
//            console.log(error)
//            });
//    }

//initial state login field
const Login = props => { //declaration of method
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


    const UserLogin = () => {
        Axios.post('http://localhost:50854/Users/authenticate', loginInputs)

            .then(function (response) {
                console.log(response)
                loginInputs.Username = '';
                loginInputs.Password = '';
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
                    <Text style={styles.title}>Log In</Text>
                </View>

                <View style={styles.inputContainer}>
                    <TextInput
                        placeholder=" Username"
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

                    <View style={styles.button}><TouchableOpacity><Button title="Log In" color='grey' onPress={() => {
                        UserLogin()
                    }} /></TouchableOpacity></View>

                    <View style={styles.button}><TouchableOpacity><Button title="Sign Up" color='grey' onPress={() => {
                        props.navigation.navigate({ routeName: 'SignUp' });
                    }} />
                    </TouchableOpacity></View>

                </View>

            </View>

        </ImageBackground>
    );

};

export default Login;

/*const LogIn = props => {

    return (
        <View style={styles.container} >

            <View>
                <Text style={styles.title}>Log In</Text>
            </View>

            <View style={styles.inputContainer}>
                <TextInput
                    placeholder="Username"
                    style={styles.input}
                />

                <TextInput
                    placeholder="Password"
                    style={styles.input}
                />
            </View>

            <View style={styles.buttonContainer}>
                
                <View style={styles.button}><TouchableOpacity><Button title="Log In" color='grey'/></TouchableOpacity></View>

                <View style={styles.button}><TouchableOpacity><Button title="Sign Up" color='grey' onPress={() => {
                    props.navigation.navigate({ routeName: 'SignUp' });
                }} />
                </TouchableOpacity></View>

            </View>

        </View>
    );

};*/

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
