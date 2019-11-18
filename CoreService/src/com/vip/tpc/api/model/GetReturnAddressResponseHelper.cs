using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class GetReturnAddressResponseHelper : TBeanSerializer<GetReturnAddressResponse>
	{
		
		public static GetReturnAddressResponseHelper OBJ = new GetReturnAddressResponseHelper();
		
		public static GetReturnAddressResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetReturnAddressResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("header".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.tpc.api.model.common.TpcResponseHeader value;
						
						value = new com.vip.tpc.api.model.common.TpcResponseHeader();
						com.vip.tpc.api.model.common.TpcResponseHeaderHelper.getInstance().Read(value, iprot);
						
						structs.SetHeader(value);
					}
					
					
					
					
					
					if ("returnAddressMap".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, com.vip.tpc.api.model.ReturnInfo> value;
						
						value = new Dictionary<string, com.vip.tpc.api.model.ReturnInfo>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key2;
								com.vip.tpc.api.model.ReturnInfo _val2;
								_key2 = iprot.ReadString();
								
								
								_val2 = new com.vip.tpc.api.model.ReturnInfo();
								com.vip.tpc.api.model.ReturnInfoHelper.getInstance().Read(_val2, iprot);
								
								value.Add(_key2, _val2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetReturnAddressMap(value);
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
		
		
		public void Write(GetReturnAddressResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHeader() != null) {
				
				oprot.WriteFieldBegin("header");
				
				com.vip.tpc.api.model.common.TpcResponseHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("header can not be null!");
			}
			
			
			if(structs.GetReturnAddressMap() != null) {
				
				oprot.WriteFieldBegin("returnAddressMap");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, com.vip.tpc.api.model.ReturnInfo > _ir0 in structs.GetReturnAddressMap()){
					
					string _key0 = _ir0.Key;
					com.vip.tpc.api.model.ReturnInfo _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					
					com.vip.tpc.api.model.ReturnInfoHelper.getInstance().Write(_value0, oprot);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetReturnAddressResponse bean){
			
			
		}
		
	}
	
}