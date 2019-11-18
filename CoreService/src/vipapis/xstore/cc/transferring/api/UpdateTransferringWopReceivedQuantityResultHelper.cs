using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class UpdateTransferringWopReceivedQuantityResultHelper : TBeanSerializer<UpdateTransferringWopReceivedQuantityResult>
	{
		
		public static UpdateTransferringWopReceivedQuantityResultHelper OBJ = new UpdateTransferringWopReceivedQuantityResultHelper();
		
		public static UpdateTransferringWopReceivedQuantityResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UpdateTransferringWopReceivedQuantityResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCode(value);
					}
					
					
					
					
					
					if ("message".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMessage(value);
					}
					
					
					
					
					
					if ("results".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiInfo> value;
						
						value = new Dictionary<string, vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiInfo>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key0;
								vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiInfo _val0;
								_key0 = iprot.ReadString();
								
								
								_val0 = new vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiInfo();
								vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiInfoHelper.getInstance().Read(_val0, iprot);
								
								value.Add(_key0, _val0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetResults(value);
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
		
		
		public void Write(UpdateTransferringWopReceivedQuantityResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCode() != null) {
				
				oprot.WriteFieldBegin("code");
				oprot.WriteString(structs.GetCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMessage() != null) {
				
				oprot.WriteFieldBegin("message");
				oprot.WriteString(structs.GetMessage());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetResults() != null) {
				
				oprot.WriteFieldBegin("results");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiInfo > _ir0 in structs.GetResults()){
					
					string _key0 = _ir0.Key;
					vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiInfo _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					
					vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiInfoHelper.getInstance().Write(_value0, oprot);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(UpdateTransferringWopReceivedQuantityResult bean){
			
			
		}
		
	}
	
}