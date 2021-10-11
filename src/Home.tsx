import React, { FC } from "react";
import Tabs from './Tabs';

export interface IPage {
    header: string;
    tagLine: string;
    description: string;
    handleTabChanged: (selectedPage: IPage) => any;
  }

const experienceDescription: string = "Enthusiastic engineer who loves any challenge. Mainly lives in the .NET Ecosystem with a focus on creating clean, performant and testable solutions.";
// const educationDescription: string = "Workcation helps you find wok-friendly rentals in beautiful locations so you can enjoy some nice weather even when you're not on vacation.";
const personalDescription: string = "Game lover, FPS titles are where I live. Music obsessive, nothing like a live set, small club, arena or stadium. Sports enthusiast, Football, Golf and more recently Esports.";
const Home: FC = () => {
    const [currentPage, setCurrentPage] = React.useState<IPage | null>(null);

    const experiencePage: IPage = { header: "Experience", tagLine: "Senior Software Engineer.", description: experienceDescription, handleTabChanged: setCurrentPage }
    // const educationPage: IPage = { header: "Education", tagLine: "BSc (Hons) Computing.", description: educationDescription, handleTabChanged: setCurrentPage }
    const personalPage: IPage = { header: "Personal", tagLine: "Games. Music. Sports.", description: personalDescription, handleTabChanged: setCurrentPage }

    const pages: IPage[] = [ experiencePage, personalPage ];

    return (
        <div>
        <div className="grid lg:grid-cols-2 2xl:grid-cols-5 bg-gray-100 h-screen">
        <div className="max-w-md m-auto sm:max-w-xl  lg:max-w-full xl:mr-0 2xl:col-span-2">
            <div className="xl:max-w-xl">
                <h1 className="text-2xl font-bold text-gray-900 sm:text-4x1 lg:text-3xl">
                    Greg Stewart.
                    <br className="inline" />
                    <span className="text-indigo-500">{currentPage?.tagLine}</span>
                </h1>
                <p className="mt-2 text-gray-600 sm:mt-4 sm:text-xl">
                    {currentPage?.description}
                </p>
               
            </div>
        </div>
        <div className="relative px-8 py-12 lg:block 2xl:col-span-3">
          <div>
            <Tabs color="indigo"
                  tabPages={pages} />
          </div>
          <div className="relative flex flex-col min-w-0 break-words bg-white w-full h-5/6 mb-6 shadow-lg rounded">
              <div className="px-4 py-5 flex-auto">
                <div className="tab-content tab-space">
                  <div className="block">
                    <h3>Ivanti - Senior Software Engineer</h3>
                    <h4></h4>
                  </div>
                </div>
              </div>
            </div>
        </div>
      </div>
    </div>
    );
}

export default Home;