import React from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, TextInput, ImageBackground, KeyboardAvoidingView } from 'react-native';


const SignUp = props => {

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
                        placeholder=" Username"
                        style={styles.input}
                    />

                    <TextInput
                        placeholder=" Email"
                        style={styles.input}
                    />

                    <TextInput
                        secureTextEntry={true}
                        placeholder=" Password"
                        style={styles.input}
                    />

                    <TextInput
                        secureTextEntry={true}
                        placeholder=" Confirm Password"
                        style={styles.input}
                    />


                    <View style={styles.button}><TouchableOpacity><Button title="Sign Up" color='grey' /></TouchableOpacity></View>

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