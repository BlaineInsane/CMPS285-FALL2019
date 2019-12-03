import React from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, ImageBackground, ScrollView } from 'react-native';
import CourseItemComponent from '../components/CourseItemComponent';

const CMPSCourses = props => {

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

                <ScrollView width={'100%'} >

                    <View style={styles.itemContainer}>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 161'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 257'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 280'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 285'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 290'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 375'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 390'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 391'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 401'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 411'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 415'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 431'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 479'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS 482'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS Elective'} /></View>

                        <View style={styles.item}><CourseItemComponent title={'CMPS Elective'} /></View>

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
        color: 'white',
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