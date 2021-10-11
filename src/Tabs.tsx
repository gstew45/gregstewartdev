import React, { FC } from "react";
import { IPage } from './Home';

interface ITabsProps{
    color: string;
    tabPages: IPage[];
}

const Tabs: FC<ITabsProps> = ({ color, tabPages }) => {
    const [openTab, setOpenTab] = React.useState(1);
    return (
      <>
        <div className="flex flex-wrap">
          <div className="w-full">
            <ul className="flex mb-0 list-none flex-wrap pt-3 pb-4 flex-row" role="tablist" >
                {tabPages.map((page: IPage, index: number) => {
                    return <li className="-mb-px mr-2 last:mr-0 flex-auto text-center">
                    <a
                      className={
                        "text-xs font-bold px-5 py-3 shadow-lg rounded block leading-normal " +
                        (openTab === index
                          ? "text-white bg-" + color + "-500"
                          : "text-" + color + "-500 bg-white")
                      }
                      onClick={e => {
                        e.preventDefault();
                        setOpenTab(index);
                        page.handleTabChanged(page)
                      }}
                      data-toggle="tab"
                      href="#link1"
                      role="tablist"
                    >
                      {page.header}
                    </a>
                  </li>
                })}
            </ul>
          </div>
        </div>
      </>
    );
}

export default Tabs;