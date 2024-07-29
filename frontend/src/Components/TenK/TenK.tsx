import React, { useEffect, useState } from 'react';
import { CompanyTenK } from '../../company';
import { getCompanyTenK } from '../../api';
import TenKItem from './TenKItem/TenKItem';
import Spinners from '../Spinners/Spinners';

type Props = {
  ticker: string;
};

const TenK = ({ ticker }: Props) => {
  const [companyData, setCompanyData] = useState<CompanyTenK[]>();
  useEffect(() => {
    const getTenKData = async () => {
      const value = await getCompanyTenK(ticker);
      setCompanyData(value?.data);
    };
    getTenKData();
  }, [ticker]);
  return (
    <div className="inline-flex rounded-md shadow-sm m-4">
      {companyData ? (
        companyData?.slice(0, 5).map((tenk) => {
          return <TenKItem tenK={tenk} />;
        })
      ) : (
        <Spinners />
      )}
    </div>
  );
};

export default TenK;
