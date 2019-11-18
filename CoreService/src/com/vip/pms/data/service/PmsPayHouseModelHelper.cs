using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsPayHouseModelHelper : TBeanSerializer<PmsPayHouseModel>
	{
		
		public static PmsPayHouseModelHelper OBJ = new PmsPayHouseModelHelper();
		
		public static PmsPayHouseModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsPayHouseModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("activeNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActiveNo(value);
					}
					
					
					
					
					
					if ("payFavModelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsPayFavModel> value;
						
						value = new List<com.vip.pms.data.service.PmsPayFavModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsPayFavModel elem0;
								
								elem0 = new com.vip.pms.data.service.PmsPayFavModel();
								com.vip.pms.data.service.PmsPayFavModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPayFavModelList(value);
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
		
		
		public void Write(PmsPayHouseModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetActiveNo() != null) {
				
				oprot.WriteFieldBegin("activeNo");
				oprot.WriteString(structs.GetActiveNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("activeNo can not be null!");
			}
			
			
			if(structs.GetPayFavModelList() != null) {
				
				oprot.WriteFieldBegin("payFavModelList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsPayFavModel _item0 in structs.GetPayFavModelList()){
					
					
					com.vip.pms.data.service.PmsPayFavModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("payFavModelList can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsPayHouseModel bean){
			
			
		}
		
	}
	
}