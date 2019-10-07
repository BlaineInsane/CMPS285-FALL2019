import React from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity } from 'react-native';

const WelcomeScreen = props => {
    return (
        <View style={styles.container} >


            <Text style={styles.title}>Degree Progress Tracker</Text>


            <Text style={styles.subtitle}>Track your progress towards each of SELU's three Computer Science degrees.</Text>

            <View style={styles.buttonContainer}>
                <View style={styles.button}><TouchableOpacity><Button title="Log In" color='grey' onPress={() => {
                    props.navigation.navigate({ routeName: 'LogIn' });
                }} />
                </TouchableOpacity></View>

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
        flex: 1,
        backgroundColor: '#1E8449',
        alignItems: 'center',
        padding: 50,
    },
    title: {
        fontSize: 35,
        textAlign: "center",
        color: 'black',
        paddingTop: 30,
        //fontFamily: 'Helvetica',
    },
    subtitle: {
        paddingTop: 20,
        fontSize: 15,
        textAlign: "center",
        color: 'white',
        //fontFamily: 'Helvetica',
    },
    buttonContainer: {
        paddingTop: 150,
        alignItems: 'center',
        justifyContent: 'center',
        width: '100%',
    },
    button: {
        width: '100%',
        paddingBottom: 20,
    }
});

export default WelcomeScreen;