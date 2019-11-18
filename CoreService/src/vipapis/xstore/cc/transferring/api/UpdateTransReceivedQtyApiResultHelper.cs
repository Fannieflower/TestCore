using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class UpdateTransReceivedQtyApiResultHelper : TBeanSerializer<UpdateTransReceivedQtyApiResult>
	{
		
		public static UpdateTransReceivedQtyApiResultHelper OBJ = new UpdateTransReceivedQtyApiResultHelper();
		
		public static UpdateTransReceivedQtyApiResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UpdateTransReceivedQtyApiResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("update_result_map".Equals(schemeField.Trim())){
						
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
						
						structs.SetUpdate_result_map(value);
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
		
		
		public void Write(UpdateTransReceivedQtyApiResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetUpdate_result_map() != null) {
				
				oprot.WriteFieldBegin("update_result_map");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, vipapis.xstore.cc.transferring.api.UpdateTransReceivedQtyApiInfo > _ir0 in structs.GetUpdate_result_map()){
					
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
		
		
		public void Validate(UpdateTransReceivedQtyApiResult bean){
			
			
		}
		
	}
	
}