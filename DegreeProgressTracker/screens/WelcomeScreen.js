import React from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, ImageBackground } from 'react-native';

const WelcomeScreen = props => {
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
        </ImageBackground>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        //backgroundColor: '#1E8449',
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

/*
Test Button for Categories Screen

Insert code below on line 36 to use button

<View style={styles.button}><TouchableOpacity><Button title="Course Categories Screen Test" color='grey' onPress={() => {
    props.navigation.navigate({ routeName: 'CourseCategories' });
}} />
</TouchableOpacity></View>*/ 