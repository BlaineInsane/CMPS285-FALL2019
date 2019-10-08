import React from 'react';
import { StyleSheet, Text, TextInput, View, Button, TouchableOpacity } from 'react-native';

const LogIn = props => {

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
        paddingTop: 30,
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

export default LogIn;

/** Log In button on line 27, Send info to API for communication with DB */