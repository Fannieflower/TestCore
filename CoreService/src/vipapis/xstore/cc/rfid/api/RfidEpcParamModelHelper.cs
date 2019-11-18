using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.rfid.api{
	
	
	
	public class RfidEpcParamModelHelper : TBeanSerializer<RfidEpcParamModel>
	{
		
		public static RfidEpcParamModelHelper OBJ = new RfidEpcParamModelHelper();
		
		public static RfidEpcParamModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RfidEpcParamModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transferNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransferNo(value);
					}
					
					
					
					
					
					if ("details".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.rfid.api.RfidEpcDetailModel> value;
						
						value = new List<vipapis.xstore.cc.rfid.api.RfidEpcDetailModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.rfid.api.RfidEpcDetailModel elem0;
								
								elem0 = new vipapis.xstore.cc.rfid.api.RfidEpcDetailModel();
								vipapis.xstore.cc.rfid.api.RfidEpcDetailModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDetails(value);
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
		
		
		public void Write(RfidEpcParamModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransferNo() != null) {
				
				oprot.WriteFieldBegin("transferNo");
				oprot.WriteString(structs.GetTransferNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transferNo can not be null!");
			}
			
			
			if(structs.GetDetails() != null) {
				
				oprot.WriteFieldBegin("details");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.rfid.api.RfidEpcDetailModel _item0 in structs.GetDetails()){
					
					
					vipapis.xstore.cc.rfid.api.RfidEpcDetailModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("details can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RfidEpcParamModel bean){
			
			
		}
		
	}
	
}