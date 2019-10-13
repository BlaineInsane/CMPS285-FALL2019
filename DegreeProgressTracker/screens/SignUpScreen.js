import React from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, TextInput } from 'react-native';

const SignUp = props => {

    return (
        <View style={styles.container}>

            <View>

                <Text style={styles.title}>Sign Up</Text>

            </View>

            <View style={styles.inputContainer}>

                <TextInput
                    placeholder=" Username"
                    style={styles.input}
                />

                <TextInput
                    placeholder=" Email"
                    style={styles.input}
                />

                <TextInput
                    placeholder=" Password"
                    style={styles.input}
                />

                <TextInput
                    placeholder=" Confirm Password"
                    style={styles.input}
                />

                <View style={styles.button}><TouchableOpacity><Button title="Sign Up" color='grey' /></TouchableOpacity></View>

                <View style={styles.button}><TouchableOpacity><Button title="Log In" color='grey' onPress={() => {
                    props.navigation.navigate({ routeName: 'LogIn' });
                }} /></TouchableOpacity></View>

            </View>
        </View>
    );

};

const styles = StyleSheet.create({

    container: {
        height: '100%',
        width: '100%',
        backgroundColor: '#1E8449',
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
        paddingBottom: 150,
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