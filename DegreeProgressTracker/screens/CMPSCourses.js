import React, { useState } from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, ImageBackground, ScrollView } from 'react-native';
import CourseItem from '../components/CourseItem';

const CMPSCourses = props => {

    var [modalOptions] = useState({
        isModalVisible: false,
    })
    
    const changeModalOptions = (event) => {
        modalOptions.isModalVisible = !modalOptions.isModalVisible;
    };

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
                <Text style={styles.title}>CMPS Courses</Text>
            </View>

            <ScrollView width={'100%'}>

                <View style={styles.itemContainer}>

                    <View style={styles.item} 
                        onPress={() => {
                            changeModalOptions();
                        }}
                    ><CourseItem title={'CMPS 161'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 257'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 280'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 285'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 290'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 375'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 390'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 391'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 401'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 411'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 415'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 431'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 479'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS 482'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS Elective'} /></View>

                    <View style={styles.item}><CourseItem title={'CMPS Elective'} /></View>

                </View>

            </ScrollView>

            <View style={styles.buttonContainer}>
                <View style={styles.item}>
                    <TouchableOpacity>
                        <Button title="Select and Return to Course Categories" color='black' onPress={() => {
                            props.navigation.navigate({ routeName: 'CourseCategories' });
                        }} />
                    </TouchableOpacity>
                </View>
            </View>

        </View>

        </ImageBackground>

    );

};

const styles = StyleSheet.create({

    container: {
        //backgroundColor: '#1E8449',
        flex: 1,
        alignItems: 'center',
        width: '100%',
    },
    title: {
        fontSize: 35,
        textAlign: "center",
        color: 'black',
        paddingTop: 60,
        //fontFamily: 'Helvetica',
    },
    itemContainer: {
        paddingTop: 60,
        alignItems: 'center',
        justifyContent: 'center',
        width: '100%',
    },
    buttonContainer: {
        paddingTop: 20,
        alignItems: 'center',
        justifyContent: 'center',
        width: '100%',
    },
    item: {
        width: '80%',
        paddingBottom: 20,
    }

});

export default CMPSCourses;