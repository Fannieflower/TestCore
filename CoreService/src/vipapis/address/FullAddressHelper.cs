using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.address{
	
	
	
	public class FullAddressHelper : TBeanSerializer<FullAddress>
	{
		
		public static FullAddressHelper OBJ = new FullAddressHelper();
		
		public static FullAddressHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(FullAddress structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("cities".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.address.City> value;
						
						value = new List<vipapis.address.City>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.address.City elem0;
								
								elem0 = new vipapis.address.City();
								vipapis.address.CityHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCities(value);
					}
					
					
					
					
					
					if ("address".Equals(schemeField.Trim())){
						
						needSkip = false;
						vipapis.address.Address value;
						
						value = new vipapis.address.Address();
						vipapis.address.AddressHelper.getInstance().Read(value, iprot);
						
						structs.SetAddress(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(FullAddress structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCities() != null) {
				
				oprot.WriteFieldBegin("cities");
				
				oprot.WriteListBegin();
				foreach(vipapis.address.City _item0 in structs.GetCities()){
					
					
					vipapis.address.CityHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cities can not be null!");
			}
			
			
			if(structs.GetAddress() != null) {
				
				oprot.WriteFieldBegin("address");
				
				vipapis.address.AddressHelper.getInstance().Write(structs.GetAddress(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(FullAddress bean){
			
			
		}
		
	}
	
}