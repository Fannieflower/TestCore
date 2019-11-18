using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class VipLinkCheckVOHelper : TBeanSerializer<VipLinkCheckVO>
	{
		
		public static VipLinkCheckVOHelper OBJ = new VipLinkCheckVOHelper();
		
		public static VipLinkCheckVOHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VipLinkCheckVO structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("linkType".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.adp.api.open.service.VipLinkTypeEnum? value;
						
						value = com.vip.adp.api.open.service.VipLinkTypeEnumUtil.FindByName(iprot.ReadString());
						
						structs.SetLinkType(value);
					}
					
					
					
					
					
					if ("landUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLandUrl(value);
					}
					
					
					
					
					
					if ("goodsId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsId(value);
					}
					
					
					
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandId(value);
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
		
		
		public void Write(VipLinkCheckVO structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetLinkType() != null) {
				
				oprot.WriteFieldBegin("linkType");
				oprot.WriteString(structs.GetLinkType().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLandUrl() != null) {
				
				oprot.WriteFieldBegin("landUrl");
				oprot.WriteString(structs.GetLandUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsId() != null) {
				
				oprot.WriteFieldBegin("goodsId");
				oprot.WriteString(structs.GetGoodsId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteString(structs.GetBrandId());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VipLinkCheckVO bean){
			
			
		}
		
	}
	
}