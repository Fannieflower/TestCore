using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.arplatform.merchModel.service{
	
	
	
	public class Jd3dModelAppRespHelper : TBeanSerializer<Jd3dModelAppResp>
	{
		
		public static Jd3dModelAppRespHelper OBJ = new Jd3dModelAppRespHelper();
		
		public static Jd3dModelAppRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Jd3dModelAppResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("channel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetChannel(value);
					}
					
					
					
					
					
					if ("spu".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSpu(value);
					}
					
					
					
					
					
					if ("vendorId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetVendorId(value);
					}
					
					
					
					
					
					if ("items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.arplatform.merchModel.service.Jd3dModel> value;
						
						value = new List<com.vip.arplatform.merchModel.service.Jd3dModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.arplatform.merchModel.service.Jd3dModel elem1;
								
								elem1 = new com.vip.arplatform.merchModel.service.Jd3dModel();
								com.vip.arplatform.merchModel.service.Jd3dModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetItems(value);
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
		
		
		public void Write(Jd3dModelAppResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetChannel() != null) {
				
				oprot.WriteFieldBegin("channel");
				oprot.WriteString(structs.GetChannel());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("channel can not be null!");
			}
			
			
			if(structs.GetSpu() != null) {
				
				oprot.WriteFieldBegin("spu");
				oprot.WriteString(structs.GetSpu());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("spu can not be null!");
			}
			
			
			if(structs.GetVendorId() != null) {
				
				oprot.WriteFieldBegin("vendorId");
				oprot.WriteI32((int)structs.GetVendorId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("vendorId can not be null!");
			}
			
			
			if(structs.GetItems() != null) {
				
				oprot.WriteFieldBegin("items");
				
				oprot.WriteListBegin();
				foreach(com.vip.arplatform.merchModel.service.Jd3dModel _item0 in structs.GetItems()){
					
					
					com.vip.arplatform.merchModel.service.Jd3dModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Jd3dModelAppResp bean){
			
			
		}
		
	}
	
}