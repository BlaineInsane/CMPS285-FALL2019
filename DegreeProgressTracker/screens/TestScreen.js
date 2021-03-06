import React, { useState } from 'react';
import Axios from 'axios';
import { Button, StyleSheet, Text, TextInput, TouchableOpacity, View, ImageBackground } from 'react-native';
import AppSettings from "../AppSettings"

const TestScreen = props => { 

    var [MajorName] = useState({
        majorName: "",
    })

    const majorNameChangeHandler = (event) => {
        MajorName.majorName = event.nativeEvent.text;
    }


    const createMajor = () => {
        const url = `${AppSettings.baseUrl}/Majors`;

        Axios.post(url, MajorName)

            .then(function (response) {
                 console.log(response.data)
            })
            .catch(function (error) {
                console.log(error)
                console.log(error.response.data)
                console.log(error.response.headers)
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
                        placeholder=" Major name goes here"
                        onChange={majorNameChangeHandler}
                        style={styles.input}
                    />
                </View>

                <View style={styles.buttonContainer}>
                    <View style={styles.button}><TouchableOpacity><Button title="Add Major" color='grey' onPress={() => {
                        createMajor();
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