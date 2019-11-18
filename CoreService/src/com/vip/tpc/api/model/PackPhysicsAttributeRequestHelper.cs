using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class PackPhysicsAttributeRequestHelper : TBeanSerializer<PackPhysicsAttributeRequest>
	{
		
		public static PackPhysicsAttributeRequestHelper OBJ = new PackPhysicsAttributeRequestHelper();
		
		public static PackPhysicsAttributeRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PackPhysicsAttributeRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("header".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.tpc.api.model.common.TpcRequestHeader value;
						
						value = new com.vip.tpc.api.model.common.TpcRequestHeader();
						com.vip.tpc.api.model.common.TpcRequestHeaderHelper.getInstance().Read(value, iprot);
						
						structs.SetHeader(value);
					}
					
					
					
					
					
					if ("packPhysicsAttrs".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.tpc.api.model.PackPhysicsAttr> value;
						
						value = new List<com.vip.tpc.api.model.PackPhysicsAttr>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.tpc.api.model.PackPhysicsAttr elem2;
								
								elem2 = new com.vip.tpc.api.model.PackPhysicsAttr();
								com.vip.tpc.api.model.PackPhysicsAttrHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPackPhysicsAttrs(value);
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
		
		
		public void Write(PackPhysicsAttributeRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHeader() != null) {
				
				oprot.WriteFieldBegin("header");
				
				com.vip.tpc.api.model.common.TpcRequestHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("header can not be null!");
			}
			
			
			if(structs.GetPackPhysicsAttrs() != null) {
				
				oprot.WriteFieldBegin("packPhysicsAttrs");
				
				oprot.WriteListBegin();
				foreach(com.vip.tpc.api.model.PackPhysicsAttr _item0 in structs.GetPackPhysicsAttrs()){
					
					
					com.vip.tpc.api.model.PackPhysicsAttrHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("packPhysicsAttrs can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PackPhysicsAttributeRequest bean){
			
			
		}
		
	}
	
}