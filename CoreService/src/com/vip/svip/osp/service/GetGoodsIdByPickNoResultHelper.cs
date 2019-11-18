using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class GetGoodsIdByPickNoResultHelper : TBeanSerializer<GetGoodsIdByPickNoResult>
	{
		
		public static GetGoodsIdByPickNoResultHelper OBJ = new GetGoodsIdByPickNoResultHelper();
		
		public static GetGoodsIdByPickNoResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetGoodsIdByPickNoResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("goodsItemList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.svip.osp.service.GoodsBaseItem> value;
						
						value = new List<com.vip.svip.osp.service.GoodsBaseItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.svip.osp.service.GoodsBaseItem elem0;
								
								elem0 = new com.vip.svip.osp.service.GoodsBaseItem();
								com.vip.svip.osp.service.GoodsBaseItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetGoodsItemList(value);
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
		
		
		public void Write(GetGoodsIdByPickNoResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGoodsItemList() != null) {
				
				oprot.WriteFieldBegin("goodsItemList");
				
				oprot.WriteListBegin();
				foreach(com.vip.svip.osp.service.GoodsBaseItem _item0 in structs.GetGoodsItemList()){
					
					
					com.vip.svip.osp.service.GoodsBaseItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetGoodsIdByPickNoResult bean){
			
			
		}
		
	}
	
}